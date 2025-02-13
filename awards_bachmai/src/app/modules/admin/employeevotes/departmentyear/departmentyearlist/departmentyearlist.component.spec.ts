import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartmentyearlistComponent } from './departmentyearlist.component';

describe('InspirationalpersonyearlistComponent', () => {
  let component: DepartmentyearlistComponent;
  let fixture: ComponentFixture<DepartmentyearlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DepartmentyearlistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DepartmentyearlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
