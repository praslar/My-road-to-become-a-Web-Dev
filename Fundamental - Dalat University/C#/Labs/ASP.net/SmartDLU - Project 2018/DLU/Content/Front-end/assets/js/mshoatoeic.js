var mshoatoeic = {
	is_answer: 0,
	is_tapescript: 0,
	send_answer_training: function(callback){
		var self = this;
		var form = $('#testing_form');
	    var total = $("#testing_form input[type=radio]:checked").size();
	    if (total == 0){
	        message("Bạn phải trả lời câu hỏi trước khi xem kết quả");
	        return false;
	    }
	    $("#testing_answer_button").remove();
	    $.ajax({
	        type: "POST",
	        url: form.attr( 'action' ),
	        data: form.serialize(),
	        dataType : 'json',
	        success: function( data ) {
	            if (data.status == 'error'){
	                message(data.message);
	                return false;
	            }
	            $('input[type=radio][name^="answer"]').attr('disabled', true);
	            $.each( data.arrQuestion , function( k1, question ) {
	            	$("#tapescript_content_" + question.question_id).html(question.detail);
				  	$.each( question.answer , function( k2, answer ) { 
				  		$.each( answer , function( k3, answer_detail ) { 
				  			//console.log(answer_detail);
				  			$("#tapescript_answer_" + answer_detail.answer_id).text(answer_detail.content);
				  			if(typeof(answer_detail.user_answer_result) != 'undefined') {
				  				if (answer_detail.user_answer_result == 1) {
				  					$("#test_answer_label_" + answer_detail.answer_id).addClass('success');
				  					$("#fulltest_question_shortcut").find('.cau[data-question='+ answer_detail.question_id +'] a').addClass("true");
				  				}
				  				else {
				  					$("#test_answer_label_" + answer_detail.answer_id).addClass('error');
				  					$("#fulltest_question_shortcut").find('.cau[data-question='+ answer_detail.question_id +'] a').addClass("false");
				  				}
				  				//////////// FULLTEST ///////
				  			}
				  			else {
				  				if (parseInt(answer_detail.correct) == 1) {
				  					$("#test_answer_label_" + answer_detail.answer_id).addClass('test_answer_success_pendding');
				  				}
				  			}
				  		});
				  	});
				});
				self.is_answer = 1;
				if (typeof(callback) === "function") {
	                callback.call(self,data);
	            } 
	        }
	    });
	},
	tapescript: function(){
		if (this.is_answer == 0) {
			this.send_answer_training(this.show_tapescript());
		}
		else {
			this.show_tapescript();
		}
		this.is_tapescript = 1;
	},
	show_tapescript: function() {
		$(".answer_content").show();
		$(".testing_result_button").remove();
		$(".test_answer_success_pendding").addClass('success_answer');
	},
	send_answer_fulltest: function(){
		var self = this;
		$('#show_count_down').countdown('stop');
		this.send_answer_training(function(data){
			//console.log(data);
			var score_detail = data.score_detail;
			$("#test_result").find("span").text('Kết quả: ' + score_detail.c + '/' + data.total_question );
			var html = '<div id="fulltest_result"><div class="result_detail"> <label>Listening</label> <div class="result_score result_score_list">' + score_detail.l + '</div> <div class="clearfix"></div> </div> <div class="result_detail"> <label>Reading</label> <div class="result_score result_score_read">' + score_detail.r + '</div> <div class="clearfix"></div> </div> <div class="result_detail"> <label>Đúng sai</label> <div class="result_score result_count"><span>'+ score_detail.c  + '</span>/' + data.total_question + '</div> <div class="clearfix"></div> </div> <div class="result_detail "> <label>Tổng điểm</label> <div class="result_score result_score_total result_highlight">'+ data.score_total + '</div> <div class="clearfix"></div> </div></div>';
			var option = {};
			option.button = ['<button type="button" data-dismiss="modal" class="btn btn-primary" onclick="mshoatoeic.tapescript()">Hiện đáp án</button>'];
			option.title = 'Kết quả test';
			message(html,option);
			$("#button_send_answer").remove();
			$("#test_result").bind("click",function(){
				console.log(self.is_tapescript);
				if (self.is_tapescript == 1) {
					delete(option.button);
				}
	            message(html,option);
	            
	        });
		});
		fulltest_change_page(1);
	},
	send_answer_writing: function() {
		var self = this;
		var form = $('#testing_form');
		$('#show_count_down_writing').countdown('stop');
		var postData = form.serialize();
		$.ajax({
	        type: "POST",
	        url: form.attr( 'action' ),
	        data: postData,
	        dataType : 'json',
	        beforeSend: function() {
	        	$("#button_send_answer").remove();
	        },
	        success: function( data ) {
	            if (data.status == 'error'){
	                message(data.message);
	                return false;
	            }
	            $("#fulltest_content").find("textarea").remove();
	            self.is_answer = 1;
	            $.each( data.data.arrQuestion , function( k1, question ) {
	            	console.log(data.data.arr_answer[question.question_id]);
	            	$("#test_question_" + question.question_id).find(".tapescript_content").html(question.detail_answer);
	            	$("#test_question_" + question.question_id).find(".writing_input").html(data.data.arr_answer[question.question_id]);
	            });
	            var option = {};
	            option.button = ['<button type="button" data-dismiss="modal" class="btn btn-primary" onclick="window.history.back()">Trở lại</button>','<button type="button" data-dismiss="modal" class="btn btn-primary" onclick="mshoatoeic.tapescript()">Hiện đáp án</button>'];
	            return message(data.message,option);
	        }
	    });
	},
	stop_audio_html5: function () {
	    var audioClass = document.getElementsByClassName("html5_audio");
	    if (audioClass.length > 0) {
	        $.each( audioClass, function( index ) {
	            audioClass[index].pause();
	        });
	    }
	}
}
function fulltest_change_page(page) {
    var limit = parseInt($("#fulltest_page").attr("data-limit"));
    $("#fulltest_content").find(".question").hide();
    $("#fulltest_content").find(".fullest_page_" + page).show();
    var part = parseInt($("#fulltest_content").find(".fullest_page_" + page).attr("data-part"));
    /// part 
    $("#fulltest_part_head").find(".fulltest_part").find("a").removeClass("active");
    $("#fulltest_part_head").find('.fulltest_part[data-part="' + part +'"]').find("a").addClass("active");
    $("#fulltest_page").attr("data-page",page);
    // shortcut
    if (page == limit-1) {
        $("#fulltest_page").find(".next").hide();
    }
    else {
        $("#fulltest_page").find(".next").show();
    }
    if (page == 1) {
        $("#fulltest_page").find(".back").hide();
    }
    else {
        $("#fulltest_page").find(".back").show();
    }
    $("#fulltest_question_shortcut").find(".viewing").removeClass("viewing");
    $("#fulltest_question_shortcut").find('.cau[data-page="' + page + '"]').addClass("viewing");
    // scroll 
    $('html,body').animate({
        scrollTop: $('#testing_form').offset().top
    }, 200);
    //////////////// UNSET SOUND ////////////
    mshoatoeic.stop_audio_html5();
}
/** UTIL **/
$(document).ready(function() {
	// Click đáp án của question
	$('input[type=radio][name^="answer"]').change(function() {
		var question_id = $(this).data('question');
		var iquestion_id = $(this).data('iquestion');			//Thứ tự câu hỏi / 200 câu
		var name = $(this).attr('name');
		console.log(question_id,iquestion_id);
		//remove active & active
		$("#testing_answer_" + question_id + "_" + iquestion_id).find(".fulltest_answer_label").removeClass("active");
		//$("#test_answer_label_" +question_id).addClass("active")
		$(this).parent().addClass("active");
		// add class to box result
		if ($("#fulltest_question_shortcut").length) {
			$("#fulltest_question_shortcut").find(".cau_" + iquestion_id).find("a").addClass("gray");
		}
	});
});