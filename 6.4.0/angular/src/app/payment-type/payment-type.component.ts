import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  PagedListingComponentBase,
  PagedRequestDto
} from '@shared/paged-listing-component-base';
import {
  PaymentTypeServiceProxy,
  PaymentTypeDto,
  PaymentTypeDtoPagedResultDto
} from '@shared/service-proxies/service-proxies';
import { CreatePaymentTypeDialogComponent } from './create-payment-type/create-payment-type.component';
import { EditPaymentTypeDialogComponent } from './edit-payment-type/edit-payment-type.component';

class PagedPaymentTypesRequestDto extends PagedRequestDto {
  keyword: string;
}

@Component({
  templateUrl: './PaymentTypes.component.html',
  animations: [appModuleAnimation()]
})
export class PaymentTypesComponent extends PagedListingComponentBase<PaymentTypeDto> {
  PaymentTypes: PaymentTypeDto[] = [];
  keyword = '';

  constructor(
    injector: Injector,
    private _PaymentTypesService: PaymentTypeServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedPaymentTypesRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;

    this._PaymentTypesService
      .getAll(request.keyword, request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: PaymentTypeDtoPagedResultDto) => {
        this.PaymentTypes = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(PaymentType: PaymentTypeDto): void {
    abp.message.confirm(
      this.l('PaymentTypeDeleteWarningMessage', PaymentType.displayName),
      undefined,
      (result: boolean) => {
        if (result) {
          this._PaymentTypesService
            .delete(PaymentType.id)
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

  createPaymentType(): void {
    this.showCreateOrEditPaymentTypeDialog();
  }

  editPaymentType(PaymentType: PaymentTypeDto): void {
    this.showCreateOrEditPaymentTypeDialog(PaymentType.id);
  }

  showCreateOrEditPaymentTypeDialog(id?: number): void {
    let createOrEditPaymentTypeDialog: BsModalRef;
    if (!id) {
      createOrEditPaymentTypeDialog = this._modalService.show(
        CreatePaymentTypeDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditPaymentTypeDialog = this._modalService.show(
        EditPaymentTypeDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditPaymentTypeDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }
}
