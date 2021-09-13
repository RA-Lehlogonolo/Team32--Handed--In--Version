import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  PagedListingComponentBase,
  PagedRequestDto
} from '@shared/paged-listing-component-base';
import {
  PaymentStatusServiceProxy,
  PaymentStatusDto,
  PaymentStatusDtoPagedResultDto
} from '@shared/service-proxies/service-proxies';
import { CreatePaymentStatusDialogComponent } from './create-payment-status/create-payment-status.component';
import { EditPaymentStatusDialogComponent } from './edit-payment-status/edit-payment-status.component';

class PagedPaymentStatussRequestDto extends PagedRequestDto {
  keyword: string;
}

@Component({
  templateUrl: './PaymentStatuss.component.html',
  animations: [appModuleAnimation()]
})
export class PaymentStatussComponent extends PagedListingComponentBase<PaymentStatusDto> {
  PaymentStatuss: PaymentStatusDto[] = [];
  keyword = '';

  constructor(
    injector: Injector,
    private _PaymentStatussService: PaymentStatusServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedPaymentStatussRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;

    this._PaymentStatussService
      .getAll(request.keyword, request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: PaymentStatusDtoPagedResultDto) => {
        this.PaymentStatuss = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(PaymentStatus: PaymentStatusDto): void {
    abp.message.confirm(
      this.l('PaymentStatusDeleteWarningMessage', PaymentStatus.displayName),
      undefined,
      (result: boolean) => {
        if (result) {
          this._PaymentStatussService
            .delete(PaymentStatus.id)
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

  createPaymentStatus(): void {
    this.showCreateOrEditPaymentStatusDialog();
  }

  editPaymentStatus(PaymentStatus: PaymentStatusDto): void {
    this.showCreateOrEditPaymentStatusDialog(PaymentStatus.id);
  }

  showCreateOrEditPaymentStatusDialog(id?: number): void {
    let createOrEditPaymentStatusDialog: BsModalRef;
    if (!id) {
      createOrEditPaymentStatusDialog = this._modalService.show(
        CreatePaymentStatusDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditPaymentStatusDialog = this._modalService.show(
        EditPaymentStatusDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditPaymentStatusDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }
}
