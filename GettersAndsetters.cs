// namespace csharpBeginning
// {
//    class GettersAndsetters
//    {
//     public string movieName;
//     public string Hero;
//     private string rating;  // make the value to private 

//     public GettersAndsetters (string aMovieName,string aHero,string aRating){
//         movieName=aMovieName;
//         Hero=aHero;
//         Rating=aRating;
//     }

//     public string Rating { // this is not a function it is Property
//         get{return rating ; } // using set for accesing the rating. if i add any other value it access that
//         set{
//             if(value=="U"||value=="U/A"||value=="A"||value=="S"){ // set allow to modify the value
//                 rating = value;
//             }
//            else{
//              rating="N/A";
//            }
        
//         }
//     }


//    }
// }
