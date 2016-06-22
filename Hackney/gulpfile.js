var gulp = require('gulp');
var sass = require('gulp-sass');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');

var paths = {
    sass: "./client/styles/sass/"
};

gulp.task('sass', function () {
    gulp.src(paths.sass + '*.scss')
        .pipe(sass())
        .pipe(gulp.dest('./client/styles/css'));
});

gulp.task('compress', function () {
    return gulp.src('client/scripts/ts/*.js')
	  .pipe(concat('app.js'))
      .pipe(uglify())
      .pipe(gulp.dest('client/scripts/'));
});

gulp.task('default', ['compress', 'sass']);