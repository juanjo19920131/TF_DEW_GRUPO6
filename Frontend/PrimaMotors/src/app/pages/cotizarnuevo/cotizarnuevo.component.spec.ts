import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CotizarnuevoComponent } from './cotizarnuevo.component';

describe('CotizarnuevoComponent', () => {
  let component: CotizarnuevoComponent;
  let fixture: ComponentFixture<CotizarnuevoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CotizarnuevoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CotizarnuevoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
