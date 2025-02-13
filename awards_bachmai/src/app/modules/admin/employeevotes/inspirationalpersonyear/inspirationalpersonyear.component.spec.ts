import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InspirationalpersonyearComponent } from './inspirationalpersonyear.component';

describe('InspirationalpersonyearComponent', () => {
  let component: InspirationalpersonyearComponent;
  let fixture: ComponentFixture<InspirationalpersonyearComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InspirationalpersonyearComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InspirationalpersonyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
