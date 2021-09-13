import {
  Component,
  Injector,
  OnInit,
  EventEmitter,
  Output,
} from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { forEach as _forEach, includes as _includes, map as _map } from 'lodash-es';
import { AppComponentBase } from '@shared/app-component-base';
import {
  ProductTypeServiceProxy,
  GetProductTypeForEditOutput,
  ProductTypeDto,
  PermissionDto,
  ProductTypeEditDto,
  FlatPermissionDto
} from '@shared/service-proxies/service-proxies';

@Component({
  templateUrl: 'edit-product-type.component.html'
})
export class EditProductTypeDialogComponent extends AppComponentBase
  implements OnInit {
  saving = false;
  id: number;
  ProductType = new ProductTypeEditDto();
  permissions: FlatPermissionDto[];
  grantedPermissionNames: string[];
  checkedPermissionsMap: { [key: string]: boolean } = {};

  @Output() onSave = new EventEmitter<any>();

  constructor(
    injector: Injector,
    private _ProductTypeService: ProductTypeServiceProxy,
    public bsModalRef: BsModalRef
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this._ProductTypeService
      .getProductTypeForEdit(this.id)
      .subscribe((result: GetProductTypeForEditOutput) => {
        this.ProductType = result.ProductType;
        this.permissions = result.permissions;
        this.grantedPermissionNames = result.grantedPermissionNames;
        this.setInitialPermissionsStatus();
      });
  }

  setInitialPermissionsStatus(): void {
    _map(this.permissions, (item) => {
      this.checkedPermissionsMap[item.name] = this.isPermissionChecked(
        item.name
      );
    });
  }

  isPermissionChecked(permissionName: string): boolean {
    return _includes(this.grantedPermissionNames, permissionName);
  }

  onPermissionChange(permission: PermissionDto, $event) {
    this.checkedPermissionsMap[permission.name] = $event.target.checked;
  }

  getCheckedPermissions(): string[] {
    const permissions: string[] = [];
    _forEach(this.checkedPermissionsMap, function (value, key) {
      if (value) {
        permissions.push(key);
      }
    });
    return permissions;
  }

  save(): void {
    this.saving = true;

    const ProductType = new ProductTypeDto();
    ProductType.init(this.ProductType);
    ProductType.grantedPermissions = this.getCheckedPermissions();

    this._ProductTypeService.update(ProductType).subscribe(
      () => {
        this.notify.info(this.l('SavedSuccessfully'));
        this.bsModalRef.hide();
        this.onSave.emit();
      },
      () => {
        this.saving = false;
      }
    );
  }
}