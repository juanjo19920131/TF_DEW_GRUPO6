import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SolicitudNewComponent } from './solicitud-new.component';

describe('SolicitudNewComponent', () => {
  let component: SolicitudNewComponent;
  let fixture: ComponentFixture<SolicitudNewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SolicitudNewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SolicitudNewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
