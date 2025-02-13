import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ScientificresearchyearlistComponent } from './scientificresearchyearlist.component';

describe('InspirationalpersonyearlistComponent', () => {
  let component: ScientificresearchyearlistComponent;
  let fixture: ComponentFixture<ScientificresearchyearlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ScientificresearchyearlistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ScientificresearchyearlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
