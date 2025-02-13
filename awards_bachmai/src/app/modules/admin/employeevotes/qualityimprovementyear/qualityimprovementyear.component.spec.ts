import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QualityimprovementyearComponent } from './qualityimprovementyear.component';

describe('QualityimprovementyearComponent', () => {
  let component: QualityimprovementyearComponent;
  let fixture: ComponentFixture<QualityimprovementyearComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [QualityimprovementyearComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(QualityimprovementyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
