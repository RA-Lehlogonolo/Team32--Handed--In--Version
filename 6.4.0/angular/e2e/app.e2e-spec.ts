import { VillageBoardTemplatePage } from './app.po';

describe('VillageBoard App', function() {
  let page: VillageBoardTemplatePage;

  beforeEach(() => {
    page = new VillageBoardTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
