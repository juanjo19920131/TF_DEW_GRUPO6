import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComprausadoListComponent } from './comprausado-list.component';

describe('ComprausadoListComponent', () => {
  let component: ComprausadoListComponent;
  let fixture: ComponentFixture<ComprausadoListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComprausadoListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ComprausadoListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
