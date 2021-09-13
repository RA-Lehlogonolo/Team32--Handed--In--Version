import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  PagedListingComponentBase,
  PagedRequestDto
} from '@shared/paged-listing-component-base';
import {
  ProductTypeServiceProxy,
  ProductTypeDto,
  ProductTypeDtoPagedResultDto
} from '@shared/service-proxies/service-proxies';
import { CreateProductTypeDialogComponent } from './create-product-type/create-product-type.component';
import { EditProductTypeDialogComponent } from './edit-product-type/edit-product-type.component';

class PagedProductTypesRequestDto extends PagedRequestDto {
  keyword: string;
}

@Component({
  templateUrl: './ProductTypes.component.html',
  animations: [appModuleAnimation()]
})
export class ProductTypesComponent extends PagedListingComponentBase<ProductTypeDto> {
  ProductTypes: ProductTypeDto[] = [];
  keyword = '';

  constructor(
    injector: Injector,
    private _ProductTypesService: ProductTypeServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedProductTypesRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;

    this._ProductTypesService
      .getAll(request.keyword, request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ProductTypeDtoPagedResultDto) => {
        this.ProductTypes = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(ProductType: ProductTypeDto): void {
    abp.message.confirm(
      this.l('ProductTypeDeleteWarningMessage', ProductType.displayName),
      undefined,
      (result: boolean) => {
        if (result) {
          this._ProductTypesService
            .delete(ProductType.id)
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('SuccessfullyDeleted'));
                this.refresh();
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }

  createProductType(): void {
    this.showCreateOrEditProductTypeDialog();
  }

  editProductType(ProductType: ProductTypeDto): void {
    this.showCreateOrEditProductTypeDialog(ProductType.id);
  }

  showCreateOrEditProductTypeDialog(id?: number): void {
    let createOrEditProductTypeDialog: BsModalRef;
    if (!id) {
      createOrEditProductTypeDialog = this._modalService.show(
        CreateProductTypeDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditProductTypeDialog = this._modalService.show(
        EditProductTypeDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditProductTypeDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }
}
