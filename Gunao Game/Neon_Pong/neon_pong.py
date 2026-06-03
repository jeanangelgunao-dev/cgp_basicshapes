import pygame
import random
import os

# ----------------------------
# Neon Ping Pong
# ----------------------------

pygame.init()
pygame.mixer.init()

WIDTH, HEIGHT = 1000, 600

screen = pygame.display.set_mode((WIDTH, HEIGHT))
pygame.display.set_caption("Neon Ping Pong")

clock = pygame.time.Clock()

# Colors
PINK = (255, 105, 180)
HOT_PINK = (255, 20, 147)
PURPLE = (186, 85, 211)
LAVENDER = (230, 230, 250)
WHITE = (255, 255, 255)
DARK_BG = (20, 10, 30)

font = pygame.font.SysFont("comicsansms", 42, bold=True)
small_font = pygame.font.SysFont("comicsansms", 28)

# ----------------------------
# Assets Folder
# ----------------------------

ASSET_FOLDER = "assets"

# Create folder automatically
if not os.path.exists(ASSET_FOLDER):
    os.makedirs(ASSET_FOLDER)

# Sound effects
paddle_sound = None
score_sound = None
wall_sound = None
menu_sound = None

# Load sounds safely
try:
    paddle_sound = pygame.mixer.Sound(
        os.path.join(ASSET_FOLDER, "paddle.wav")
    )
except:
    print("Missing paddle.wav")

try:
    score_sound = pygame.mixer.Sound(
        os.path.join(ASSET_FOLDER, "score.wav")
    )
except:
    print("Missing score.wav")

try:
    wall_sound = pygame.mixer.Sound(
        os.path.join(ASSET_FOLDER, "wall.wav")
    )
except:
    print("Missing wall.wav")

try:
    menu_sound = pygame.mixer.Sound(
        os.path.join(ASSET_FOLDER, "menu.wav")
    )
except:
    print("Missing menu.wav")

# Background music
try:
    pygame.mixer.music.load(
        os.path.join(ASSET_FOLDER, "music.mp3")
    )

    pygame.mixer.music.set_volume(0.5)
    pygame.mixer.music.play(-1)

except:
    print("Missing music.mp3")

# Game settings
PADDLE_WIDTH = 18
PADDLE_HEIGHT = 120
BALL_SIZE = 22
PADDLE_SPEED = 8
BALL_SPEED = 7

# Player mode
player_mode = None


# ----------------------------
# Paddle Class
# ----------------------------

class Paddle:
    def __init__(self, x, y):
        self.rect = pygame.Rect(
            x,
            y,
            PADDLE_WIDTH,
            PADDLE_HEIGHT
        )

    def move_up(self):
        if self.rect.top > 0:
            self.rect.y -= PADDLE_SPEED

    def move_down(self):
        if self.rect.bottom < HEIGHT:
            self.rect.y += PADDLE_SPEED

    def draw(self, surface):

        # Reduced glow effect
        for glow in range(12, 0, -4):

            glow_surface = pygame.Surface(
                (
                    self.rect.width + glow * 2,
                    self.rect.height + glow * 2
                ),
                pygame.SRCALPHA
            )

            alpha = max(10, 70 - glow * 4)

            pygame.draw.rect(
                glow_surface,
                (255, 105, 180, alpha),
                (
                    0,
                    0,
                    self.rect.width + glow * 2,
                    self.rect.height + glow * 2
                ),
                border_radius=15
            )

            surface.blit(
                glow_surface,
                (
                    self.rect.x - glow,
                    self.rect.y - glow
                )
            )

        pygame.draw.rect(
            surface,
            HOT_PINK,
            self.rect,
            border_radius=12
        )

        pygame.draw.rect(
            surface,
            WHITE,
            self.rect,
            3,
            border_radius=12
        )


# ----------------------------
# Ball Class
# ----------------------------

class Ball:
    def __init__(self):
        self.reset()

    def reset(self):

        self.rect = pygame.Rect(
            WIDTH // 2 - BALL_SIZE // 2,
            HEIGHT // 2 - BALL_SIZE // 2,
            BALL_SIZE,
            BALL_SIZE
        )

        self.speed_x = random.choice(
            [-BALL_SPEED, BALL_SPEED]
        )

        self.speed_y = random.choice(
            [-BALL_SPEED, BALL_SPEED]
        )

    def move(self):

        self.rect.x += self.speed_x
        self.rect.y += self.speed_y

        # Wall collision
        if self.rect.top <= 0 or self.rect.bottom >= HEIGHT:

            self.speed_y *= -1

            if wall_sound:
                wall_sound.play()

    def draw(self, surface):

        # Reduced glow effect
        for glow in range(14, 0, -4):

            glow_surface = pygame.Surface(
                (
                    BALL_SIZE + glow * 2,
                    BALL_SIZE + glow * 2
                ),
                pygame.SRCALPHA
            )

            alpha = max(10, 80 - glow * 4)

            pygame.draw.ellipse(
                glow_surface,
                (255, 182, 193, alpha),
                (
                    0,
                    0,
                    BALL_SIZE + glow * 2,
                    BALL_SIZE + glow * 2
                )
            )

            surface.blit(
                glow_surface,
                (
                    self.rect.x - glow,
                    self.rect.y - glow
                )
            )

        pygame.draw.ellipse(
            surface,
            LAVENDER,
            self.rect
        )

        pygame.draw.ellipse(
            surface,
            WHITE,
            self.rect,
            2
        )


# Create game objects
left_paddle = Paddle(
    40,
    HEIGHT // 2 - 60
)

right_paddle = Paddle(
    WIDTH - 58,
    HEIGHT // 2 - 60
)

ball = Ball()

left_score = 0
right_score = 0


# ----------------------------
# Background
# ----------------------------

def draw_background():

    screen.fill(DARK_BG)

    # Stars
    for i in range(60):

        x = (i * 97) % WIDTH
        y = (i * 53) % HEIGHT

        radius = (i % 3) + 1

        pygame.draw.circle(
            screen,
            PURPLE,
            (x, y),
            radius
        )

    # Center line
    for y in range(0, HEIGHT, 35):

        pygame.draw.rect(
            screen,
            PINK,
            (
                WIDTH // 2 - 3,
                y,
                6,
                20
            )
        )


# ----------------------------
# Draw Scores
# ----------------------------

def draw_scores():

    left_text = font.render(
        str(left_score),
        True,
        PINK
    )

    right_text = font.render(
        str(right_score),
        True,
        PINK
    )

    screen.blit(
        left_text,
        (WIDTH // 4, 30)
    )

    screen.blit(
        right_text,
        (WIDTH * 3 // 4, 30)
    )


# ----------------------------
# AI Movement
# ----------------------------

def ai_move():

    if ball.rect.centery < right_paddle.rect.centery:
        right_paddle.move_up()

    elif ball.rect.centery > right_paddle.rect.centery:
        right_paddle.move_down()


# ----------------------------
# Main Menu Button
# ----------------------------

def draw_main_menu_button():

    button_rect = pygame.Rect(
        20,
        20,
        160,
        50
    )

    pygame.draw.rect(
        screen,
        HOT_PINK,
        button_rect,
        border_radius=12
    )

    pygame.draw.rect(
        screen,
        WHITE,
        button_rect,
        2,
        border_radius=12
    )

    text = small_font.render(
        "Main Menu",
        True,
        WHITE
    )

    screen.blit(
        text,
        (
            button_rect.x +
            button_rect.width // 2 -
            text.get_width() // 2,

            button_rect.y +
            button_rect.height // 2 -
            text.get_height() // 2
        )
    )

    return button_rect


# ----------------------------
# Show Menu
# ----------------------------

def show_menu():

    global player_mode

    while True:

        draw_background()

        title = font.render(
            "Neon Ping Pong",
            True,
            HOT_PINK
        )

        mode1 = small_font.render(
            "Press 1 - Single Player",
            True,
            WHITE
        )

        mode2 = small_font.render(
            "Press 2 - Two Players",
            True,
            WHITE
        )

        controls = small_font.render(
            "P1: W/S   |   P2: UP/DOWN",
            True,
            LAVENDER
        )

        screen.blit(
            title,
            (
                WIDTH // 2 -
                title.get_width() // 2,
                150
            )
        )

        screen.blit(
            mode1,
            (
                WIDTH // 2 -
                mode1.get_width() // 2,
                270
            )
        )

        screen.blit(
            mode2,
            (
                WIDTH // 2 -
                mode2.get_width() // 2,
                330
            )
        )

        screen.blit(
            controls,
            (
                WIDTH // 2 -
                controls.get_width() // 2,
                430
            )
        )

        pygame.display.flip()

        for event in pygame.event.get():

            if event.type == pygame.QUIT:
                pygame.quit()
                return False

            if event.type == pygame.KEYDOWN:

                if event.key == pygame.K_1:
                    player_mode = 1
                    return True

                if event.key == pygame.K_2:
                    player_mode = 2
                    return True


# ----------------------------
# Start Menu
# ----------------------------

if not show_menu():
    raise SystemExit


# ----------------------------
# Main Game Loop
# ----------------------------

running = True

while running:

    clock.tick(60)

    draw_background()

    # Draw menu button
    menu_button = draw_main_menu_button()

    for event in pygame.event.get():

        if event.type == pygame.QUIT:
            running = False

        # Main menu click
        if event.type == pygame.MOUSEBUTTONDOWN:

            if menu_button.collidepoint(event.pos):

                if menu_sound:
                    menu_sound.play()

                left_score = 0
                right_score = 0

                ball.reset()

                if not show_menu():
                    running = False

    keys = pygame.key.get_pressed()

    # Left paddle controls
    if keys[pygame.K_w]:
        left_paddle.move_up()

    if keys[pygame.K_s]:
        left_paddle.move_down()

    # Right paddle controls
    if player_mode == 2:

        if keys[pygame.K_UP]:
            right_paddle.move_up()

        if keys[pygame.K_DOWN]:
            right_paddle.move_down()

    else:
        ai_move()

    # Ball movement
    ball.move()

    # Paddle collisions
    if ball.rect.colliderect(left_paddle.rect):

        ball.speed_x *= -1

        if paddle_sound:
            paddle_sound.play()

    if ball.rect.colliderect(right_paddle.rect):

        ball.speed_x *= -1

        if paddle_sound:
            paddle_sound.play()

    # Score system
    if ball.rect.left <= 0:

        right_score += 1

        if score_sound:
            score_sound.play()

        ball.reset()

    if ball.rect.right >= WIDTH:

        left_score += 1

        if score_sound:
            score_sound.play()

        ball.reset()

    # Draw objects
    left_paddle.draw(screen)
    right_paddle.draw(screen)
    ball.draw(screen)

    draw_scores()

    pygame.display.flip()

pygame.quit()