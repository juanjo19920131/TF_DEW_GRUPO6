import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SolicitudtallerComponent } from './solicitudtaller.component';

describe('SolicitudtallerComponent', () => {
  let component: SolicitudtallerComponent;
  let fixture: ComponentFixture<SolicitudtallerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SolicitudtallerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SolicitudtallerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
