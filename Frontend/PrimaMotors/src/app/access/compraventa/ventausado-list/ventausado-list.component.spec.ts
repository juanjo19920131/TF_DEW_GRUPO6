import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VentausadoListComponent } from './ventausado-list.component';

describe('VentausadoListComponent', () => {
  let component: VentausadoListComponent;
  let fixture: ComponentFixture<VentausadoListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VentausadoListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VentausadoListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
