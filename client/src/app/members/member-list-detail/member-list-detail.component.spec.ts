import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MemberListDetailComponent } from './member-list-detail.component';

describe('MemberListDetailComponent', () => {
  let component: MemberListDetailComponent;
  let fixture: ComponentFixture<MemberListDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MemberListDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MemberListDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
