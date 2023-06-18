  mergeInto(LibraryManager.library, {

    Hello: function () {
      window.alert("Hello, world!");
      console.log("Hello world!");
    },

/*
    RateGame: function () {
      ysdk.feedback.canReview()
          .then(({ value, reason }) => {
              if (value) {
                  ysdk.feedback.requestReview()
                      .then(({ feedbackSent }) => {
                          console.log(feedbackSent);
                      })
              } else {
                  console.log(reason)
              }
          })
    },
*/

    ShowAdv: function(){
      ysdk.adv.showFullscreenAdv({
        callbacks: {
          onClose: function(wasShown) {
          // some action after close
          },
          onError: function(error) {
          // some action on error
          }
        }
      })
    },

/*
    ShowRewardAdv: function(){
      ysdk.adv.showRewardedVideo({
        callbacks: {
          onOpen: () => {
            console.log('Video ad open.');
          },
          onRewarded: () => {
            console.log('Rewarded!');
          },
          onClose: () => {
            console.log('Video ad closed.');
            myGameInstance.SendMessage('Yandex', 'RewardAdvButton');
          }, 
          onError: (e) => {
            console.log('Error while open video ad:', e);
            myGameInstance.SendMessage('Yandex', 'RewardAdvButton');
          }
        }
      })
    },
*/

/*    
    LeaderBoard: function(maxScore){
      ysdk.getLeaderboards()
      .then(lb => {
        lb.setLeaderboardScore('leader', maxScore);
      });
    },

    GetLang: function (){
      var lang = ysdk.environment.i18n.lang;
      var bufferSize = lengthBytesUTF8(lang) + 1;
      var buffer = _malloc(bufferSize);
      stringToUTF8(lang, buffer, bufferSize);
      return buffer;
    },
*/


    /*
    SaveExtern: function(date){
      var dateString = UTF8ToString(date);
      var myobj = JSON.parse(dateString);
      player.setData(myobj);
    },

    LoadExtern: function(){
      player.getData().then(_date => {
        const myJSON = JSON.stringify(_date);
        myGameInstance.SendMessage('GameManager', 'SetPlayerInfo', myJSON);
      });
    }, 
    */



  });