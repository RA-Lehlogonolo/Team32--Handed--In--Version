import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  PagedListingComponentBase,
  PagedRequestDto
} from '@shared/paged-listing-component-base';
import {
  OrderStatusServiceProxy,
  OrderStatusDto,
  OrderStatusDtoPagedResultDto
} from '@shared/service-proxies/service-proxies';
import { CreateOrderStatusDialogComponent } from './create-Order-status/create-Order-status.component';
import { EditOrderStatusDialogComponent } from './edit-Order-status/edit-Order-status.component';

class PagedOrderStatussRequestDto extends PagedRequestDto {
  keyword: string;
}

@Component({
  templateUrl: './OrderStatuss.component.html',
  animations: [appModuleAnimation()]
})
export class OrderStatussComponent extends PagedListingComponentBase<OrderStatusDto> {
  OrderStatuss: OrderStatusDto[] = [];
  keyword = '';

  constructor(
    injector: Injector,
    private _OrderStatussService: OrderStatusServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedOrderStatussRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;

    this._OrderStatussService
      .getAll(request.keyword, request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: OrderStatusDtoPagedResultDto) => {
        this.OrderStatuss = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(OrderStatus: OrderStatusDto): void {
    abp.message.confirm(
      this.l('OrderStatusDeleteWarningMessage', OrderStatus.displayName),
      undefined,
      (result: boolean) => {
        if (result) {
          this._OrderStatussService
            .delete(OrderStatus.id)
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

  createOrderStatus(): void {
    this.showCreateOrEditOrderStatusDialog();
  }

  editOrderStatus(OrderStatus: OrderStatusDto): void {
    this.showCreateOrEditOrderStatusDialog(OrderStatus.id);
  }

  showCreateOrEditOrderStatusDialog(id?: number): void {
    let createOrEditOrderStatusDialog: BsModalRef;
    if (!id) {
      createOrEditOrderStatusDialog = this._modalService.show(
        CreateOrderStatusDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditOrderStatusDialog = this._modalService.show(
        EditOrderStatusDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditOrderStatusDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }
}
