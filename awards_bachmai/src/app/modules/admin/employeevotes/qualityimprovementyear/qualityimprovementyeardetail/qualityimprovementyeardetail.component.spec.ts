import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QualityimprovementyeardetailComponent } from './qualityimprovementyeardetail.component';

describe('InspirationalpersonyeardetailComponent', () => {
  let component: QualityimprovementyeardetailComponent;
  let fixture: ComponentFixture<QualityimprovementyeardetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [QualityimprovementyeardetailComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(QualityimprovementyeardetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
