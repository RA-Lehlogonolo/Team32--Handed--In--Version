import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { NzNotificationService } from 'ng-zorro-antd/notification';

@Component({
  selector: 'app-menu-type',
  templateUrl: './menu-type.component.html',
  styleUrls: ['./menu-type.component.css']
})
export class MenuTypeComponent implements OnInit {
  validateForm: any;
  isAddMenuTypeVisible: boolean;
  isUpdateMenuTypeVisible: boolean;
  isDeleteMenuTypeVisible: boolean;
  constructor(
    private fb: FormBuilder,
    private notification: NzNotificationService,
  ) { }

  ngOnInit(): void {
    this.validateForm = this.fb.group({
      description: [null, [Validators.required]],
      name: [null, [Validators.required]],
      aType: [null, [Validators.required]],
      campus: [null, [Validators.required]],
    });
  }
  
  showAddMenuTypeModal(): void {
    this.isAddMenuTypeVisible = true;

  }

  handleOkAddMenuType(): void {
    this.isAddMenuTypeVisible = false;


  }

  handleCancelAddMenuType(): void {
    this.isAddMenuTypeVisible = false;


  }

  showUpdateMenuTypeModal(): void {
    this.isUpdateMenuTypeVisible = true;
  }

  handleOkUpdateMenuType(): void {
    this.isUpdateMenuTypeVisible = false;
  }

  handleCancelUpdateMenuType(): void {
    this.isUpdateMenuTypeVisible = false;
  }

  showDeleteMenuTypeModal(): void {
    this.isDeleteMenuTypeVisible = true;
  }

  handleOkDeleteMenuType(): void {
    this.isDeleteMenuTypeVisible = false;
    this.notification.create('success','','Successfully deleted menu type!',
      {
        nzStyle: {backgroundColor: 'green',color: 'white' },
        nzClass: ''
      }
    );

  }
  handleCancelDeleteMenuType(): void {
    this.isDeleteMenuTypeVisible = false;
  }

  confirm(): void {
    this.notification.create('success','','Successfully updated menu type!',
      {
        nzStyle: {backgroundColor: 'green',color: 'white' },
        nzClass: ''
      }
    );
    this.isUpdateMenuTypeVisible = false;


  }

  confirmAdd(): void {
    this.notification.create('success','','Successfully added menu type!',
      {
        nzStyle: {backgroundColor: 'green',color: 'white' },
        nzClass: ''
      }
    );
    this.isAddMenuTypeVisible = false;


  }


  listOfData: any[] = [
    {
      menuType: "Vegeterian",

    },
    {
      menuType: "Standard",

    },
    {
      menuType: "TuksRes",

    },

  ];
}

