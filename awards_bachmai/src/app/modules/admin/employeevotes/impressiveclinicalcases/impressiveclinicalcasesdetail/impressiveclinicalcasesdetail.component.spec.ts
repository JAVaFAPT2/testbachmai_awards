import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ImpressiveclinicalcasesdetailComponent } from './impressiveclinicalcasesdetail.component';

describe('InspirationalpersonyeardetailComponent', () => {
  let component: ImpressiveclinicalcasesdetailComponent;
  let fixture: ComponentFixture<ImpressiveclinicalcasesdetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ImpressiveclinicalcasesdetailComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ImpressiveclinicalcasesdetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
