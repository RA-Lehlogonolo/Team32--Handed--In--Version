import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MaintenanceRequestStatusComponent } from './maintenance-request-status.component';

describe('MaintenanceRequestStatusComponent', () => {
  let component: MaintenanceRequestStatusComponent;
  let fixture: ComponentFixture<MaintenanceRequestStatusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MaintenanceRequestStatusComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MaintenanceRequestStatusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
