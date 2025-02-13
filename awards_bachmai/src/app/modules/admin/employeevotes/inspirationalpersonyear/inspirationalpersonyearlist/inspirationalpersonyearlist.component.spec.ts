import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InspirationalpersonyearlistComponent } from './inspirationalpersonyearlist.component';

describe('InspirationalpersonyearlistComponent', () => {
  let component: InspirationalpersonyearlistComponent;
  let fixture: ComponentFixture<InspirationalpersonyearlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InspirationalpersonyearlistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InspirationalpersonyearlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
