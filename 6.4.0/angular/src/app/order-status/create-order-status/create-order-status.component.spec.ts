import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateOrderStatusComponent } from './create-order-status.component';

describe('CreateOrderStatusComponent', () => {
  let component: CreateOrderStatusComponent;
  let fixture: ComponentFixture<CreateOrderStatusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateOrderStatusComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateOrderStatusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
