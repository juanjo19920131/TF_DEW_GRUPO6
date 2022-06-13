import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CompranuevoNewComponent } from './compranuevo-new.component';

describe('CompranuevoNewComponent', () => {
  let component: CompranuevoNewComponent;
  let fixture: ComponentFixture<CompranuevoNewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CompranuevoNewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CompranuevoNewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
