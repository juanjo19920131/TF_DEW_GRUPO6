import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComprausadoNewComponent } from './comprausado-new.component';

describe('ComprausadoNewComponent', () => {
  let component: ComprausadoNewComponent;
  let fixture: ComponentFixture<ComprausadoNewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComprausadoNewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ComprausadoNewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
