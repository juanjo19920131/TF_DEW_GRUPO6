import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CompranuevoListComponent } from './compranuevo-list.component';

describe('CompranuevoListComponent', () => {
  let component: CompranuevoListComponent;
  let fixture: ComponentFixture<CompranuevoListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CompranuevoListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CompranuevoListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
