var wrappers = $('.tWrap'),
    perspectiveInput = $('#perspective').on('input', onSetPerspective);

function onSetPerspective(e){
  perspectiveInput.next('span').text( this.value + 'px' );
  wrappers.css('perspective', this.value + 'px')
}