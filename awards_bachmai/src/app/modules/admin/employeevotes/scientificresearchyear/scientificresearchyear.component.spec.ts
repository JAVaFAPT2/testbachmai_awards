import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ScientificresearchyearComponent } from './scientificresearchyear.component';

describe('ScientificresearchyearComponent', () => {
  let component: ScientificresearchyearComponent;
  let fixture: ComponentFixture<ScientificresearchyearComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ScientificresearchyearComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ScientificresearchyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
