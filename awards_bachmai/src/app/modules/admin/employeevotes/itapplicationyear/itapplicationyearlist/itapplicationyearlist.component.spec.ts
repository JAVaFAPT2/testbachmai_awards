import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItapplicationyearlistComponent } from './itapplicationyearlist.component';

describe('InspirationalpersonyearlistComponent', () => {
  let component: ItapplicationyearlistComponent;
  let fixture: ComponentFixture<ItapplicationyearlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ItapplicationyearlistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ItapplicationyearlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
