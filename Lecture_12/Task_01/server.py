import redis
import random
with redis.Redis() as redis_server:  # Контекстный менеджер with для работы с сервером, автоматом закроет соединение при окончании команд

    redis_server.lpush("queue",random.randint(0,10))

# redis_server = redis.Redis()  // Создаем подключение к локальному сервис
# redis_server.close() 