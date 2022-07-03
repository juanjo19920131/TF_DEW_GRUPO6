import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CotizarusadoComponent } from './cotizarusado.component';

describe('CotizarusadoComponent', () => {
  let component: CotizarusadoComponent;
  let fixture: ComponentFixture<CotizarusadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CotizarusadoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CotizarusadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
