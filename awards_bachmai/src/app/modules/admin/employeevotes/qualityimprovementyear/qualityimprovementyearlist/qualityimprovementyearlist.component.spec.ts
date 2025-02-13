import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QualityimprovementyearlistComponent } from './qualityimprovementyearlist.component';

describe('InspirationalpersonyearlistComponent', () => {
  let component: QualityimprovementyearlistComponent;
  let fixture: ComponentFixture<QualityimprovementyearlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [QualityimprovementyearlistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(QualityimprovementyearlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
