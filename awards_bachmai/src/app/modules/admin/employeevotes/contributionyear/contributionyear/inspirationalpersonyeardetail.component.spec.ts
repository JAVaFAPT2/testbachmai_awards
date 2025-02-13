import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InspirationalpersonyeardetailComponent } from './inspirationalpersonyeardetail.component';

describe('InspirationalpersonyeardetailComponent', () => {
  let component: InspirationalpersonyeardetailComponent;
  let fixture: ComponentFixture<InspirationalpersonyeardetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InspirationalpersonyeardetailComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InspirationalpersonyeardetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
