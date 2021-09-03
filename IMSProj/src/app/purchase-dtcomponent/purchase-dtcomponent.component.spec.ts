import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PurchaseDtcomponentComponent } from './purchase-dtcomponent.component';

describe('PurchaseDtcomponentComponent', () => {
  let component: PurchaseDtcomponentComponent;
  let fixture: ComponentFixture<PurchaseDtcomponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PurchaseDtcomponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PurchaseDtcomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
