mergeInto(LibraryManager.library,
	{
		InitFileLoader: function () {
			var input = document.getElementById('fileSelector');
			if (!input) {
				input = document.createElement('input');
				input.type = 'file';
				input.id = 'fileSelector';

				document.getElementsByTagName('body')[0].appendChild(input);

				input.onchange = function (e) {
					//원하는 액션 취할 것, 여기서는 Full Directory 를 얻어온다. input.value
					window.alert(input.value);
					return;
				};
			}
		}
});