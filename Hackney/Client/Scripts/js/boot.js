var language = location.search.replace("?language=","") || "en";

var globalization = {
	"en" : {
		"copyRight" : "2016",
		"Home" : {
			"Welcome" : "Welcome",
			"By" : "By"
		}
	},
	"en-US" : {
		"Home" : {
			"Welcome" : "Welcome"
		}
	},
	"en-GB" : {
		"Home" : {
			"Welcome" : "Welcome"
		}
	},
	"en-AU": {
	    "Home": {
	        "Welcome": "Welcome"
	    }
	},
	"pl" : {
		"Home" : {
			"Welcome" : "Witam"
		}
	},
	"ar" : {
		"Home" : {
			"Welcome" : "مرحبا"
		}
	},
	getValue : function(path){
		var sagments = path.split('/'); 
		return globalization[language][sagments[0]][sagments[1]] || globalization["en"][sagments[0]][sagments[1]];
	}
};



function translate(){
	if(language!="en"){
		var apiKey = "AIzaSyDuo0h9XdfQEoaIyCwX4HWilVAijZ0mEBU";
		var html = $('.choose-problem h1').html();


		var query = "https://www.googleapis.com/language/translate/v2?format=html&target="+language+"&source=en&key="+apiKey+"&q="+html;
		$.getJSON(query,function(response){
			$('.choose-problem h1').html(response.data.translations[0].translatedText);
		});


		html = $('.cd-faq-content').first().html();


		query = "https://www.googleapis.com/language/translate/v2?format=html&target="+language+"&source=en&key="+apiKey+"&q="+html;
		$.getJSON(query,function(response){
			$('.cd-faq-content').first().html(response.data.translations[0].translatedText);
		});

		html = $($('.cd-faq-trigger')[1]).html();


		query = "https://www.googleapis.com/language/translate/v2?format=html&target="+language+"&source=en&key="+apiKey+"&q="+html;
		$.getJSON(query,function(response){
			$($('.cd-faq-trigger')[1]).html(response.data.translations[0].translatedText);
		});
	}
}

translate();

//

//should be used in commands
//globalization.getValue("Home/Welcome");


var commands = {
	"showMenu": function() {
		console.log('menu is excuted');
		alert('Here is your menu');
	},
   "showColors": function(){
		$("a[href='#colors']").click();
   },
   "showBranding": function(){
		$("a[href='#branding']").click();
   },
   "showTypography": function(){
		$("a[href='#typography']").click();
   },
   "showButtons": function(){
		$("a[href='#buttons']").click();
   },
   "showIcons": function(){
		$("a[href='#icons']").click();
   },
   "showForm": function(){
		$("a[href='#form']").click();
   }
};
speechSynthesis.cancel();
speechSynthesis.getVoices();
var speak = function (text, callback, error) {
    speechSynthesis.cancel();
    speechSynthesis.getVoices();
    var speaker = new SpeechSynthesisUtterance();    
    speaker.lang = language;

    speaker.voice = speechSynthesis.getVoices().filter(function (voice) { return voice.lang.search(language) > -1; })[0];

	speaker.onend = function () {
		if (callback) {
			callback();
		}
	};

	speaker.onerror = function (e) {
		if (error) {
			error(e);
		}
	};


	//var loopLength = text.length / 1024;
	//for (var i = 0; i < loopLength; i++) {
	speaker.text = text;//.substr(i * 1024, i + 1 * 1024);
	speechSynthesis.speak(speaker);
	    //console.log("xxx ", text.substr(i * 1024, i + 1 * 1024))
	//}

	
};

var listen = function(callback,error){
	var recognition = new webkitSpeechRecognition();
	recognition.lang = language;
	recognition.continuous = true;
	recognition.interimResults = true;

	recognition.onerror = function (e) {
		if (error) {
		    error(e);
		}
	};

	recognition.onend = function (e) {
		if (callback) {
		    callback('no results');
		}
	};

	recognition.onresult = function (e) {
	recognition.onend = null;
		if (callback) {
		    callback({
		        transcript: e.results[e.results.length-1][0].transcript,
		        confidence: e.results[e.results.length-1][0].confidence
		    });
		}
	};
	recognition.start();
};

function indexing(){
    
	$.getJSON( "/data/test-data.json?x=1", function( data ) {
		handelData(data);
	},function(data){
		handelData(data);
	});

	function handelData(data){
		var index = lunr(function () {
		    this.field('title', {boost: 10})
		    this.field('body')
		    this.ref('id')
		  });

		 for (post in data) {
		    var doc = {
		        'title': data[post].title,
		        'body': data[post].body,
		        'href': data[post].href
		    };
		    index.add(doc);
		}

	    document.body.innerHTML= JSON.stringify(index)+
		"<br><br><br><br><br><br><br><br><br><br><br><br><br>"+
		"To test run from console:"+"<br>"+
		"var indexDump = JSON.parse(/*past your json here*/);<br>"+
		"window.index = lunr.Index.load(indexDump);<br>";
	}
 }