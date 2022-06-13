import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VentausadoNewComponent } from './ventausado-new.component';

describe('VentausadoNewComponent', () => {
  let component: VentausadoNewComponent;
  let fixture: ComponentFixture<VentausadoNewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VentausadoNewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VentausadoNewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
